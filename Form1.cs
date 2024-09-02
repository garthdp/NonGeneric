using System.Collections.Generic;
namespace NonGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDictionary();
            printHashset();
            printQueue();
        }

        private void printDictionary()
        {
            Dictionary<string, int> ComputerScience = new Dictionary<string, int>();
            ComputerScience.Add("BCAD1", 89);
            ComputerScience.Add("BCAD2", 56);
            ComputerScience.Add("BCAD3", 43);

            String strCourse = "BCAD3";
            if (ComputerScience.ContainsKey(strCourse))
            {
                int value = ComputerScience[strCourse];
                this.lstDictionary.Items.Add(strCourse + " has " + value + " students");
            }
            strCourse = "BCOM2";
            if (!ComputerScience.ContainsKey(strCourse))
            {
                this.lstDictionary.Items.Add(strCourse + " is a stupid qualification and should not be on earth");
            }
            this.lstDictionary.Items.Add("Dictionary has " + ComputerScience.Count + " courses.");
        }

        private void printHashset()
        {
            string[] array =
            {
                "C#",
                "Java",
                "Java",
                "PHP",
                "HTML",
                "VB.Net",
                "C#"
            };
            //use the hashset to remove duplicates
            var hash = new HashSet<string>(array);
            String[] array2 = hash.ToArray();
            this.lstHashSet.Items.Add(string.Join(",", array2));
        }

        private void printQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            this.lstQueue.Items.Add("Results from QUEUE (FIFO)");
            foreach(var item in queue)
            {
                this.lstQueue.Items.Add(item);
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            this.lstQueue.Items.Add("Result from STACK (LIFO)");
            foreach (var item in stack)
            {
                this.lstQueue.Items.Add(item);
            }
        }
    }
}
