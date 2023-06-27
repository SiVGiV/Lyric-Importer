using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using iTunesLib;

namespace freshLyrics
{
    public partial class LyricFetcher : Form
    {
        iTunesApp itunes = new iTunesApp();
        public LyricFetcher()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void get_Click(object sender, EventArgs e)
        {
            get.Enabled = false;
            overwrite.Enabled = false;
            int count, done = 0 ;
            IITTrackCollection tracks = itunes.SelectedTracks;
            if (tracks != null)
            {
                count = tracks.Count;
                foreach (IITFileOrCDTrack track in tracks)
                {
                    trackName.Text = track.Artist + " - " + track.Name;
                    if ((track.Lyrics == null) || (track.Lyrics == "") || overwrite.Checked)
                        if (radioButton1.Checked)
                            track.Lyrics = ParseAZLyrics(track);
                        else
                            track.Lyrics = ParseWikia(track);
                    done++;
                    progressBar.Value = 100 * done / count;
                }
            }
            get.Enabled = true;
            overwrite.Enabled = true;
        }
        public string ParseAZLyrics(IITFileOrCDTrack track)
        {
            string lyrics = "";
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string url = "http://azlyrics.com/lyrics/";
            if ((track.Artist == null) || (track.Artist == ""))
                url += rgx.Replace(track.AlbumArtist, "").ToLower();
            else
                url += rgx.Replace(track.Artist, "").ToLower();
            url += "/" + rgx.Replace(track.Name, "").ToLower() + ".html";
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string code = client.DownloadString(url);
                lyrics = code.Substring(code.IndexOf("<!-- Usage"));
                lyrics = lyrics.Substring(0, lyrics.IndexOf("</div>"));
                lyrics = lyrics.Replace("\n", "").Replace("\r","");
                lyrics = lyrics.Replace("<br>", "\n");
                while (lyrics.Contains("<") && lyrics.Contains(">"))
                    lyrics = lyrics.Remove(lyrics.IndexOf("<"), lyrics.IndexOf(">") - lyrics.IndexOf("<") + 1);
            }
            catch (Exception){}
            return lyrics;
        }
        public string ParseWikia(IITFileOrCDTrack track)
        {
            string lyrics = "";
            string url = "http://api.lololyrics.com/0.5/getLyric?artist=";
            if ((track.Artist == null) || (track.Artist == ""))
                url += track.AlbumArtist.Replace(" ", "+");
            else
                url += track.Artist.Replace(" ", "+");
            url += "&track=" + track.Name.Replace(" ", "+");
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string code = client.DownloadString(url);
                lyrics = code;
                Regex rx = new Regex("/(?:<response>)(.*)(?:</response>)/g");
                lyrics = rx.Match(lyrics).Value;
                if(lyrics == "No lyric found with that artist and title")
                    lyrics = "";
            }
            catch (Exception){}
            return lyrics;
        }
        public string convertHtml(string str)
        {
            Regex r = new Regex("&#[^;]+;");
            str = r.Replace(str, delegate(Match match)
            {
                string value = match.Value.ToString().Replace("&#", "").Replace(";", "");
                int asciiCode;
                if (int.TryParse(value, out asciiCode))
                    return Convert.ToChar(asciiCode).ToString();
                else
                    return value;
            });
            return str;
        }
    }
}
