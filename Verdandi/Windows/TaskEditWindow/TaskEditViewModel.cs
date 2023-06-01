using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Windows.Input;
using Verdandi.Commands;
using Microsoft.Win32;
using System.IO;
using BLL;

namespace Verdandi.Windows.TaskEditWindow
{
    public class TaskEditViewModel : INotifyPropertyChanged
    {
        public TaskModel TaskModel { get; }

        public ICommand ScanMedia => new RelayCommand(_ => StartScanMedia());

        public event PropertyChangedEventHandler PropertyChanged;

        public TaskEditViewModel()
        {
            static List<MediaModel> getMedia()
            {
                using var db = new DataContext();
                return db.Media.ToList();
            }

            TaskModel = new TaskModel();
            MediaList = getMedia();
        }

        public TaskEditViewModel(TaskModel model = null, List<MediaModel> media = null)
        {
            TaskModel = model;
            MediaList = media;
        }

        public List<MediaModel> MediaList { get; }

        public string Name
        {
            get { return TaskModel.Name; }
            set
            {
                TaskModel.Name = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get { return TaskModel.Description; }
            set
            {
                TaskModel.Description = value;
                RaisePropertyChanged();
            }
        }

        public int Hours
        {
            get { return TaskModel.ExpectedCompletionTime.Hours; }
            set
            {
                TaskModel.ExpectedCompletionTime =
                    TimeSpan.FromHours(value)
                    + TimeSpan.FromMinutes(TaskModel.ExpectedCompletionTime.Minutes);
                RaisePropertyChanged();
            }
        }

        public int Minutes
        {
            get { return TaskModel.ExpectedCompletionTime.Minutes; }
            set
            {
                TaskModel.ExpectedCompletionTime =
                    TimeSpan.FromHours(TaskModel.ExpectedCompletionTime.Hours)
                    + TimeSpan.FromMinutes(value);
                RaisePropertyChanged();
            }
        }

        public DateTime DateStart
        {
            get { return TaskModel.DateStart; }
            set
            {
                TaskModel.DateStart = value + TaskModel.DateStart.TimeOfDay;
                RaisePropertyChanged();
            }
        }

        public TimeSpan Time
        {
            get { return TaskModel.DateStart.TimeOfDay; }
            set
            {
                TaskModel.DateStart = new DateTime(TaskModel.DateStart.Date.Ticks) + value;
                RaisePropertyChanged();
            }
        }

        private void StartScanMedia()
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mkv|All Files|*.*",
                Multiselect = true
            };

            bool? res = ofd.ShowDialog();
            if (res.HasValue && res.Value)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    MediaModel media = new()
                    {
                        MediaPath = fileName,
                        Title = Path.GetFileName(fileName)
                    };
                    DbWorker.AddMedia(media);
                }
            }


        }

        protected void RaisePropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
