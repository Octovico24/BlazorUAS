using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorUAS.Models;
using BlazorUAS.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorUASFront.Pages
{
    public partial class DetailStudentPage
    {
        [Parameter]
        public string id { get; set; }
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        public string Coordinates { get; set; }

        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        protected void Button_Click(){
            if(ButtonText == "Hide Footer"){
                CssClass = "HideFooter";
                ButtonText =  "Show Footer";
            }
            else{
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        protected void Mouse_Move(MouseEventArgs e){
            Coordinates = $"X = {e.ClientX}, Y = {e.ClientY}";
        }


    }
}