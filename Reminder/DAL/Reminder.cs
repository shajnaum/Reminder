using System;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        public DateTime ReminderDateTime { get; set; }

        public string Message { get; set; }
    }
}