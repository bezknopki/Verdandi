using DAL.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Verdandi.Windows.TaskEditWindow
{
    public class TaskEditViewModel : INotifyPropertyChanged
    {
        public TaskModel TaskModel { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public TaskEditViewModel(TaskModel model = null, List<MediaModel> media = null)
        {
            static List<MediaModel> getMedia()
            {
                using (var db = new DataContext())
                    return db.Media.ToList();
            }

            TaskModel = model ?? new TaskModel();
            MediaList = media ?? getMedia();
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

        protected void RaisePropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
