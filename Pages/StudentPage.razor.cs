using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS.Models;
using BlazorUAS.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorUAS.Pages
{
    public partial class StudentPage
    {
        public IEnumerable<Student> Student { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = (await StudentService.GetAll()).ToList();
        }

    }
}