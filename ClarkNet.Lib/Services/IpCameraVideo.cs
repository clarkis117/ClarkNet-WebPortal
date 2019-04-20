using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Core;

namespace ClarkNetWebPortal.Services
{
	/*
    /// <summary>
    /// summery launches vlc transcoding processes
    /// ex. "C:\Program Files\VideoLAN\VLC\vlc.exe" -I dummy screen:// :screen-fps=16.000000 :screen-caching=100 :sout=#transcode{vcodec=theo,vb=800,scale=1,width=600,height‌​=480,acodec=mp3}:htt‌​p{mux=ogg,dst=127.0.‌​0.1:8080/desktop.ogg‌​} :no-sout-rtp-sap :no-sout-standard-sap :ttl=1 :sout-keep
    /// </summary>
    public class IpCameraVideo
    {
        public const string VlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe";

        private Stack<Process> _processes = new Stack<Process>();

        private readonly Logger _logger;

        private readonly string _videoOutputPath;

        public IpCameraVideo(Logger logger, string videoOutputPath)
        {
            _logger = logger;

            _videoOutputPath = videoOutputPath ?? "192.168.1.6:999";
        }

        public void LaunchProcess(IpCamera camera)
        {
            try
            {
                var videoOutput = "'#standard{access=http,mux=ogg,dst="+_videoOutputPath+"}'";

                var vlcCommand = $" {camera.GetVlcUrl()} --sout {videoOutput}";

                var vlcProcess = Process.Start(VlcPath, vlcCommand);

                vlcProcess.Exited += VlcProcess_Exited;

                _processes.Push(vlcProcess);
            }
            catch (Exception e)
            {
                _logger.Error("Vlc Process failed to start: " + e.Message, e);

                throw e;
            }
        }

        /// <summary>
        /// attempts to restart process... if can't then throw exception
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VlcProcess_Exited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void StopAllProcesses()
        {
            foreach (var process in _processes)
            {
                process.Exited -= VlcProcess_Exited;

                process.Kill();

                if (!process.HasExited)
                {
                    var processKillFailedMessage = $"Process {process.Id}:{process.ProcessName} has not exited!";

                    _logger.LogError(processKillFailedMessage);

                    throw new Exception(processKillFailedMessage);
                }
            }
        }

    }
	*/
}
