using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestProject;

namespace KR1 {
    public partial class _Default : Page {
        public static int Fibonacci(int n) {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++) {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void GoButton_Click(object sender, EventArgs e) {
            int maxValue = 0;
            string result = "Unable to parse number";
            System.Text.StringBuilder resultText = new
            System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue)) {
                
                result = Fibonacci(maxValue).ToString();
            }
            WelcomeLabel1.result = result;
        }

    }
}
