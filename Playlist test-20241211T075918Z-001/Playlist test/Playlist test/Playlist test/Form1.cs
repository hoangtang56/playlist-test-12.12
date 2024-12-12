using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Playlist_test
{
    public partial class Form1 : Form
    {
        private Node2 currentSong;
        private DoublyLinkedList playlist;

        public Form1()
        {
            InitializeComponent();
            playlist = new DoublyLinkedList();
            currentSong = null;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 50; // Default volume
            trackBarVolume.Value = 50;
            labelVolume.Text = "Volume: 50%";
            // Your initialization code here
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            Timer1.Tick += Timer1_Tick;
            Timer1.Start();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentSong != null && currentSong.blink != null && currentSong.blink.element.ToString() != "Header")
            {
                currentSong = currentSong.blink;
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();

                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
            else if (currentSong == null)
            {
                MessageBox.Show("You have to add a song first.");
            }
            else
            {
                currentSong = playlist.GetFirst();
                while (currentSong.flink != null)
                    currentSong = currentSong.flink;
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";
            }    
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                currentSong = playlist.GetFirst();
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();

                labelNowPlaying.Text = "Playing: " + Path.GetFileName(
                axWindowsMediaPlayer1.URL = currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";
            }
            else
            {
                MessageBox.Show("You don't have any songs!");
            } 
                
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                //change play to pause
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    // If the media is playing, pause it
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    btn_play.Text = "Play"; // Change the button text to "Play"
                }
                else
                {
                    // If the media is paused, play it
                    axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    btn_play.Text = "Pause"; // Change the button text to "Pause"
                }


                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentSong != null && currentSong.flink != null)
            {
                currentSong = currentSong.flink;
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
                // Cập nhật TrackBar dựa trên tốc độ hiện tại
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
            else if (currentSong == null)
            {
                MessageBox.Show("You have to add a song first.");
            }
            else
            {
                currentSong = playlist.GetFirst();
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());

                // Đồng bộ SelectedIndex với bài hát hiện tại
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;
            }    
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Audio Files|*.mp3;*.wav;*.wma",
                Multiselect = true // Cho phép chọn nhiều tệp
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = ofd.FileNames; // Lấy tất cả các file được chọn

                foreach (string fileName in selectedFiles)
                {
                    string songName = Path.GetFileNameWithoutExtension(fileName); // Tên bài hát không có phần mở rộng

                    if (playlist.GetFirst() == null)
                    {
                        // Thêm bài hát đầu tiên nếu danh sách trống
                        playlist.Insert(fileName, "Header");
                        currentSong = playlist.GetFirst();
                    }
                    else
                    {
                        // Thêm bài hát vào cuối danh sách
                        Node2 lastNode = playlist.GetFirst();
                        while (lastNode.flink != null)
                        {
                            lastNode = lastNode.flink;
                        }
                        playlist.Insert(fileName, lastNode.element);
                    }

                    // Thêm bài hát vào ListBox hiển thị playlist
                    listBoxPlaylist.Items.Add(songName);

                    // Update original music files list
                    if (originalMusicFiles != null)
                    {
                        originalMusicFiles = originalMusicFiles.Concat(new[] { songName }).ToArray();
                    }
                    else
                    {
                        originalMusicFiles = new[] { songName };
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                string songToRemove = currentSong.element.ToString();
                playlist.Remove(songToRemove);
                listBoxPlaylist.Items.Remove(Path.GetFileNameWithoutExtension(songToRemove));

                // Move to the next song or previous
                if (currentSong.flink != null)
                {
                    currentSong = currentSong.flink;
                }
                else if (currentSong.blink != null && currentSong.blink.element.ToString() != "Header")
                {
                    currentSong = currentSong.blink;
                }
                else
                {
                    currentSong = null;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    labelNowPlaying.Text = "No song playing";
                    return;
                }

                // Play the new current song
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());
            }
        }

        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before shuffling.");
                return;
            }

            playlist.Shuffle();

            // Update listbox
            listBoxPlaylist.Items.Clear();
            Node2 current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }

            MessageBox.Show("Playlist shuffled!");
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before sorting.");
                return;
            }

            playlist.SortAsc();

            // Update listbox
            listBoxPlaylist.Items.Clear();
            Node2 current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }

            MessageBox.Show("Playlist sorted!");
        }

        private void btn_sortDESC_Click(object sender, EventArgs e)
        {
            if (playlist.GetFirst() == null)
            {
                MessageBox.Show("Playlist is empty. You have to add songs before sorting.");
                return;
            }

            playlist.SortDesc();

            // Update listbox
            listBoxPlaylist.Items.Clear();
            Node2 current = playlist.GetFirst();
            while (current != null)
            {
                string songName = Path.GetFileNameWithoutExtension(current.element.ToString());
                listBoxPlaylist.Items.Add(songName);
                current = current.flink;
            }

            MessageBox.Show("Playlist sorted!");
        }
        // tạo một list mới để lưu các chỉ số gốc tỏng listbox
        List<int> filteredIndices = new List<int>();
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylist.SelectedIndex >= 0)
            {
                string selectedSong = listBoxPlaylist.SelectedItem.ToString();
                Node2 node = playlist.GetFirst();
                int index = 0;
                while (node != null)
                {
                    if (Path.GetFileNameWithoutExtension(node.element.ToString()) == selectedSong)
                    {
                        currentSong = node;
                        axWindowsMediaPlayer1.URL = node.element.ToString();
                        axWindowsMediaPlayer1.Ctlcontrols.play();

                        labelNowPlaying.Text = "Playing: " + selectedSong;

                        try
                        {
                            TagLib.File file = TagLib.File.Create(node.element.ToString());
                            byte[] bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                            pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc Zoom
                        }
                        catch
                        {
                            // Nếu không có bìa nhạc
                            pictureBox1.Image = null;
                        }
                        break;
                    }
                    node = node.flink;
                    index++;
                }
            }
        }
        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            // Tính toán tỷ lệ tốc độ từ TrackBar (từ 0.5x đến 2x)
            double speed = trackBarSpeed.Value / 100.0;

            // Cập nhật tốc độ phát lại của MediaPlayer
            axWindowsMediaPlayer1.settings.rate = speed;

            // Cập nhật nhãn hiển thị tốc độ hiện tại
            labelSpeed.Text = $"Speed: {speed}x";

        }
        private void labelNowPlaying_Click(object sender, EventArgs e)
        {

        }

        private void labelSpeed_Click(object sender, EventArgs e)
        {

        }
        public static string RemoveDiacritics(string Text)
        {
            string NormalizedText = Text.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(NormalizedText, string.Empty).Normalize(NormalizationForm.FormC);
        }
        bool SearchFlag = true;
        private string[] originalMusicFiles; // To store the original list of music files
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (SearchFlag)
            {
                SearchFlag = false;

                // Store the original list of music files if not already stored
                if (originalMusicFiles == null)
                {
                    originalMusicFiles = listBoxPlaylist.Items.Cast<string>().ToArray();
                }

                // Normalize the search term to lowercase and remove diacritics
                string SearchTerm = RemoveDiacritics(search.Text.ToLower().Trim());

                List<string> Result = new List<string>();
                foreach (string FileName in originalMusicFiles)
                {
                    if (!string.IsNullOrEmpty(FileName) && RemoveDiacritics(FileName.ToLower().Trim()).Contains(SearchTerm))
                    {
                        Result.Add(FileName);
                    }
                }

                // Update the ListBox with the search results
                listBoxPlaylist.Items.Clear();
                foreach (string file in Result)
                {
                    listBoxPlaylist.Items.Add(file);
                }

                if (string.IsNullOrEmpty(search.Text.Trim()))
                {
                    listBoxPlaylist.Items.Clear();
                    foreach (var file in originalMusicFiles)
                    {
                        listBoxPlaylist.Items.Add(file);
                    }
                }

                SearchFlag = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // Dừng trình phát nhạc nếu đang phát
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying ||
                axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop(); // Dừng phát nhạc
            }

            playlist.Clear();
            listBoxPlaylist.Items.Clear();
            currentSong = null;

            // Xóa thông tin hiển thị
            labelNowPlaying.Text = "No song playing";
            btn_play.Text = "play"; // Đặt lại trạng thái nút thành "Play"
            pictureBox1.Image = null; // Xóa bìa nhạc nếu có

            // Đặt lại TrackBar và các nhãn thời gian
            trackBarProgress.Value = 0;
            trackBarProgress.Maximum = 0;
            labelTotalTime.Text = "00:00";
            labelCurrentTime.Text = "00:00";

            // Đặt lại TrackBar tốc độ và âm lượng
            trackBarSpeed.Value = 100; // Giá trị mặc định (1x tốc độ)
            axWindowsMediaPlayer1.settings.rate = 1.0; // Đặt tốc độ phát về mặc định
            labelSpeed.Text = "Speed: 1.0x"; // Cập nhật nhãn tốc độ

            trackBarVolume.Value = 50; // Giá trị mặc định (50% âm lượng)
            axWindowsMediaPlayer1.settings.volume = 50; // Đặt âm lượng về mặc định

            MessageBox.Show("Playlist cleared!");
        }

        private void btn_minus15_Click(object sender, EventArgs e)
        {
            // Tua lại 15 giây
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= 15)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 15;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0; // Nếu nhỏ hơn 15s thì về đầu bài
            }
        }

        private void btn_add15_Click(object sender, EventArgs e)
        {
            // Tua tới 15 giây
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 15 <= axWindowsMediaPlayer1.currentMedia.duration)
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 15;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration; // Nếu vượt quá thì về cuối bài
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // MediaEnded state
            {
                // Call the method to play the next song
                PlayNextSong();
                UpdateTrackBarAndLabels();
            }
        }
        private void PlayNextSong()
        {
            if (currentSong != null && currentSong.flink != null)
            {
                // Move to the next song in the list
                currentSong = currentSong.flink;
            }
            else if (currentSong == null || currentSong.flink == null)
            {
                // If we reach the end of the playlist, start from the first song
                currentSong = playlist.GetFirst();
            }
            if (currentSong != null)
            {
                // Set the URL of the next song
                axWindowsMediaPlayer1.URL = currentSong.element.ToString();

                // Wait a bit to ensure the URL is properly set before starting playback
                Task.Delay(200).ContinueWith(t =>
                {
                    // Start playing the next song
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                });

                // Update the UI with the current song info
                labelNowPlaying.Text = "Playing: " + Path.GetFileName(currentSong.element.ToString());
                int newIndex = listBoxPlaylist.Items.IndexOf(Path.GetFileNameWithoutExtension(currentSong.element.ToString()));
                listBoxPlaylist.SelectedIndex = newIndex;

                // Update the track speed UI
                trackBarSpeed.Value = (int)(axWindowsMediaPlayer1.settings.rate * 100);
                labelSpeed.Text = $"Speed: {axWindowsMediaPlayer1.settings.rate}x";

            }
        }
        private void UpdateTrackBarAndLabels()
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                // Cập nhật giá trị TrackBar
                trackBarProgress.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                trackBarProgress.Value = 0;

                // Cập nhật nhãn thời gian
                labelTotalTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"mm\:ss");
                labelCurrentTime.Text = "00:00";
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            // Set the media player's volume to the TrackBar's current value
            axWindowsMediaPlayer1.settings.volume = trackBarVolume.Value;

            // Optionally, update a label to show the current volume percentage
            labelVolume.Text = $"Volume: {trackBarVolume.Value}%";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Update the TrackBar maximum based on the song's duration
                if (axWindowsMediaPlayer1.currentMedia != null)
                {
                    trackBarProgress.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                    trackBarProgress.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;


                    // Update the label to show the current time and total duration
                    labelCurrentTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition).ToString(@"mm\:ss");
                    labelTotalTime.Text = TimeSpan.FromSeconds(axWindowsMediaPlayer1.currentMedia.duration).ToString(@"mm\:ss");
                }
            }
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBarProgress.Value;
        }
    }
}
