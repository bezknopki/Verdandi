using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Verdandi.Controls.TaskListControl
{
    public class TaskListViewModel : ViewModelBase
    {
        public List<TaskData> Tasks { get; set; }

        public TaskData SelectedTask { get; set; }

    }
}
