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
using Verdandi.Controls;

namespace Verdandi.Windows.TaskEditWindow
{
    public class TaskEditViewModel : ViewModelBase
    {
        public TaskData TaskModel { get; }

        public ICommand ScanMedia => new RelayCommand(_ => StartScanMedia());

        public TaskEditViewModel()
        {
            static List<Media> getMedia()
            {
                using var db = new DataContext();
                return db.Media.ToList();
            }

            TaskModel = new TaskData();
            MediaList = getMedia();
        }

        public TaskEditViewModel(TaskData model = null, List<Media> media = null)
        {
            TaskModel = model;
            MediaList = media;
        }

        public List<Media> MediaList { get; }

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

        public TimeSpan ExpectedCompletionTime
        {
            get { return TaskModel.ExpectedCompletionTime; }
            set
            {
                TaskModel.ExpectedCompletionTime = value;
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
                    Media media = new()
                    {
                        MediaPath = fileName,
                        Title = Path.GetFileName(fileName)
                    };
                    DbWorker.AddMedia(media);
                }
            }
        }
    }
}
