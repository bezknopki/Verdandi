using BLL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Verdandi.Commands;

namespace Verdandi.Controls.TaskListControl
{
    public class TaskListViewModel : ViewModelBase
    {
        private List<TaskData> tasks;
        private TaskData taskData;

        public List<TaskData> Tasks 
        {
            get => tasks;
            set
            {
                tasks = value;
                RaisePropertyChanged();
            }
        }

        public TaskData SelectedTask
        {
            get => taskData;
            set
            {
                taskData = value;
                RaisePropertyChanged();
            }
        }

        public ICommand RemoveTask => new RelayCommand(_ => RemoveSelectedTask());

        private void RemoveSelectedTask()
        {
            Tasks.Remove(SelectedTask);
            DbWorker.RemoveTask(SelectedTask);
        }

    }
}
