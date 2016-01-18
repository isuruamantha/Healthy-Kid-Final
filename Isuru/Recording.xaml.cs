using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace HealthyKidNew.Isuru
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Recording : Page
    {
        private MediaCapture _mediaCaptureManager;
        private StorageFile _recordStorageFile;
        private bool _recording;
        private bool _userRequestedRaw;
        private bool _rawAudioSupported;
        MessageDialog msgbox;

        public Recording()
        {
            this.InitializeComponent();
            InitializeAudioRecording();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //action method for start button
        private async void Start_button_Click(object sender, RoutedEventArgs e)
        {
            msgbox = new MessageDialog("Recording started. Go back and please press stop button to stop the recording!");
            await msgbox.ShowAsync();
            CaptureAudio();
        }

        //this method for the initilizatino purpose
        private async void InitializeAudioRecording()
        {

            _mediaCaptureManager = new MediaCapture();
            var settings = new MediaCaptureInitializationSettings();
            settings.StreamingCaptureMode = StreamingCaptureMode.Audio;
            settings.MediaCategory = MediaCategory.Other;
            settings.AudioProcessing = (_rawAudioSupported && _userRequestedRaw) ? AudioProcessing.Raw : AudioProcessing.Default;

            await _mediaCaptureManager.InitializeAsync(settings);

            Debug.WriteLine("Device initialised successfully");

            _mediaCaptureManager.RecordLimitationExceeded += new RecordLimitationExceededEventHandler(RecordLimitationExceeded);
            _mediaCaptureManager.Failed += new MediaCaptureFailedEventHandler(Failed);


        }

        //this method for the capturing the audios
        private async void CaptureAudio()
        {
            try
            {
                Debug.WriteLine("Starting record");
                String fileName = "record.m4a";
                _recordStorageFile = await KnownFolders.VideosLibrary.CreateFileAsync(fileName, CreationCollisionOption.GenerateUniqueName);

                //to record in dedicated folderhttp://www.codeproject.com/Articles/837500/Recording-Audio-in-Windows-Phone?msg=5188583#xx5188583xx

                Debug.WriteLine("Create record file successfully");
                MediaEncodingProfile recordProfile = MediaEncodingProfile.CreateM4a(AudioEncodingQuality.Auto);
                await _mediaCaptureManager.StartRecordToStorageFileAsync(recordProfile, this._recordStorageFile);
                Debug.WriteLine("Start Record successful");
                _recording = true;
            }
            catch (Exception e)
            {
                msgbox = new MessageDialog("Record Limit exceeded! Please do note exceed the record limit!");
                await msgbox.ShowAsync();
            }
        }


        private async void RecordLimitationExceeded(MediaCapture sender)
        {
            //message for the exception
            msgbox = new MessageDialog("Record Limit exceeded! Please do note exceed the record limit!");
            await msgbox.ShowAsync();
            throw new NotImplementedException();
        }

        private async void Failed(MediaCapture sender, MediaCaptureFailedEventArgs errorEventArgs)
        {
            //message for the exception
            msgbox = new MessageDialog("Recording failed. Please try again!");
            await msgbox.ShowAsync();
            throw new NotImplementedException();
        }

        //this method for the stopping the record
        private async void StopCapture()
        {

            if (_recording)
            {
                Debug.WriteLine("Stopping recording");
                await _mediaCaptureManager.StopRecordAsync();
                Debug.WriteLine("Stop recording successful");
                _recording = false;
            }

        }

        //stop button action method 
        private async void stop_button_Click(object sender, RoutedEventArgs e)
        {
            msgbox = new MessageDialog("Recording stopped. Please press on play button to play the audio!");
            await msgbox.ShowAsync();
            StopCapture();
        }

        //this method for the play the saved file
        private async void PlayRecordedCapture()
        {
            if (!_recording)
            {

                try {
                    var stream = await _recordStorageFile.OpenAsync(FileAccessMode.Read);
                    Debug.WriteLine("Recording file opened");
                    playbackElement1.AutoPlay = true;
                    playbackElement1.SetSource(stream, _recordStorageFile.FileType);
                    playbackElement1.Play();

                    msgbox = new MessageDialog("Playing your recorded audio");
                    await msgbox.ShowAsync();
                }
                catch (Exception e )
                {
                    msgbox = new MessageDialog("Please record something first! :)");
                    await msgbox.ShowAsync();
                }
                
            }

            
        }

        //this action method for the play back button 
        private void play_button_Click(object sender, RoutedEventArgs e)
        {
            PlayRecordedCapture();
        }
    }
}
