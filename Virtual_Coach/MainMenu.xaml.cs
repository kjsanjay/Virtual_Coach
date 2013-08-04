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
using System.Windows.Shapes;

namespace Virtual_Coach
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        Patient p; //will contain current patient's information
        static int defaultRepNumber = 10; // this will be the number of repitions for the all exercise option

        //create prescribed exercises to add into default prescription for ALL exercises
        //static Exercise situps = new Exercise("Situps");
        //PrescribedExercise situpsPE = new PrescribedExercise(situps, defaultRepNumber);
        //static Exercise armCurls = new Exercise("Arm Curls");
        //PrescribedExercise armCurlsPE = new PrescribedExercise(armCurls, defaultRepNumber);
        //static Exercise twoHandedStandup = new Exercise("Two Handed Standup");
        //PrescribedExercise twoHandedStandupPE = new PrescribedExercise(twoHandedStandup, defaultRepNumber);
        //static Exercise troubleCane = new Exercise("Trouble Cane");
        //PrescribedExercise troubleCanePE = new PrescribedExercise(troubleCane, defaultRepNumber);
        //static Exercise switchOnTheLight = new Exercise("Switch on the Light");
        //PrescribedExercise switchOnTheLightPE = new PrescribedExercise(switchOnTheLight, defaultRepNumber);
        //static Exercise walking = new Exercise("Walking");
        //PrescribedExercise walkingPE = new PrescribedExercise(walking, defaultRepNumber);
        //static Exercise oneHandedStandup = new Exercise("One Handed Standup");
        //PrescribedExercise oneHandedStandupPE = new PrescribedExercise(oneHandedStandup, defaultRepNumber);
        public Prescription allExPrescription = new Prescription();

        public MainMenu(Patient p1)
        {
            //add prescribed exercises into the default prescription for ALL exercises
            //allExPrescription.add(situpsPE);
            //allExPrescription.add(armCurlsPE);
            //allExPrescription.add(twoHandedStandupPE);
            //allExPrescription.add(troubleCanePE);
            //allExPrescription.add(switchOnTheLightPE);
            //allExPrescription.add(walkingPE);
            //allExPrescription.add(oneHandedStandupPE);

            //set the sent patient to a public variable
            p = p1;

            //open this window and close previous login window
            InitializeComponent();
            Application.Current.MainWindow.Close();

            //insert all possible exercises in AllExercise list box
            allExercises_listbox.Items.Add("Situps (10 reps)");
            allExercises_listbox.Items.Add("Arm Curls  (10 reps)");
            allExercises_listbox.Items.Add("Two Handed Standup (10 reps)");
            allExercises_listbox.Items.Add("Trouble Cane (10 reps)");
            allExercises_listbox.Items.Add("Switch on the Light (10 reps)");
            allExercises_listbox.Items.Add("Walking (10 reps)");
            allExercises_listbox.Items.Add("One Handed Standup (10 reps)");


            //set user profile labels
            if (p.patient_name != null)
                name_label.Content = p.patient_name;
            if (p.doctor_name != null)
                doctor_label.Content = p.doctor_name;

            //add patient's prescription to the prescripition listbox
            //for (int i = 0; i < p.patient_prescription.size(); i++ )
            //{
            //    prescription_listbox.Items.Add(
            //        p.patient_prescription.getExerciseAtLocation(i).prescribed_exercise.name_of_exercise 
            //        + " (" + p.patient_prescription.getExerciseAtLocation(i).number_of_repitions + " reps)");
            //}

        }

        //user presses Go button on "your prescription" pane
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int index = prescription_listbox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select an exercise first");
            }
            else
            {
                ExerciseScreen es = new ExerciseScreen(p.patient_prescription.prescription.ElementAt(index));
                es.Left = 250;
                es.Top = 10;
                es.ShowDialog();
            }
        }

        //user presses Go button on "all exercises" pane
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int index = allExercises_listbox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select an exercise first");
            }
            else
            {
                ExerciseScreen es = new ExerciseScreen(allExPrescription.getExerciseAtLocation(index));
                es.Left = 250;
                es.Top = 10;
                es.ShowDialog();
            }
        }

    }
}
