using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Virtual_Coach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string enteredUsername;
        public string enteredPassword;

        public MainWindow()
        {
            InitializeComponent();
            username_textBox.Focus();
        }

       

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //check username and password
            enteredUsername = username_textBox.Text;
            enteredPassword = password_textBox.Password;

            if (enteredUsername == "guest" && enteredPassword == "pass")
            {


            }
            else if (enteredUsername == "Natalie" && enteredPassword == "password")
            {
                //Exercise preparing_exercise = new Exercise("Arm Curls");
                //PrescribedExercise pexercise = new PrescribedExercise(preparing_exercise, 20);
                //Exercise preparing_exercise1 = new Exercise("Standups");
                //PrescribedExercise pexercise1 = new PrescribedExercise(preparing_exercise1, 15);
                //Exercise preparing_exercise2 = new Exercise("Two Handed Standup");
                //PrescribedExercise pexercise2 = new PrescribedExercise(preparing_exercise2, 10);
                //Exercise preparing_exercise3 = new Exercise("Arm Curls");
                //PrescribedExercise pexercise3 = new PrescribedExercise(preparing_exercise3, 25);
                //Prescription preparing_prescription = new Prescription();
                //preparing_prescription.add(pexercise);
                //preparing_prescription.add(pexercise1);
                //preparing_prescription.add(pexercise2);
                //preparing_prescription.add(pexercise3);
                //Patient patient_logging_in = new Patient("Natalie Nash", "Dr. Brungo", preparing_prescription);

                //send Patient data and open the Main Menu screen
                //MainMenu mm = new MainMenu(patient_logging_in);
                //mm.Left = 100;
                //mm.Top = 10;
                //mm.ShowDialog();
            }
            else if (enteredUsername == "Thomas" && enteredPassword == "password2")
            {
                //Exercise preparing_exerciseT = new Exercise("Arm Curls");
                //PrescribedExercise pexerciseT = new PrescribedExercise(preparing_exerciseT, 20);
                //Exercise preparing_exercise1T = new Exercise("Standups");
                //PrescribedExercise pexercise1T = new PrescribedExercise(preparing_exercise1T, 25);
                //Prescription preparing_prescription = new Prescription();
                //preparing_prescription.add(pexerciseT);
                //preparing_prescription.add(pexercise1T);

                //Patient patient_logging_in = new Patient("Natalie Nash", "Dr. Brungo", preparing_prescription);

                ////send Patient data and open the Main Menu screen
                //MainMenu mm = new MainMenu(patient_logging_in);
                //mm.Left = 100;
                //mm.Top = 10;
                //mm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username/password");
            }

            //search database for that Patient

            //just temporary example patient
            
        }

        private void username_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            username_textBox.SelectAll();
        }

        private void password_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            password_textBox.SelectAll();
        }

        private void username_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                password_textBox.Focus();

            }
        }

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                loginButton_Click(sender, e);
            }

        }

              
               
    }
}