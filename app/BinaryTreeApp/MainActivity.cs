using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views.InputMethods;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace BinaryTreeApp {
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {
        private BinaryTree _tree = new BinaryTree();
        private EditText _input;
        private Button _ins;
        private Button _preorder;
        private Button _inorder;
        private Button _postorder;
        private Button _reset;
        private TextView _result;
        private TextView _treeText;
        private Toast _toast;
        
        /// <summary>
        /// Method invoked by the app when launching the activity.
        /// </summary>
        /// <param name="savedInstanceState"></param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            // assigning the class attributes to layout ID's
            _input = FindViewById<EditText>(Resource.Id.numberInput);
            _ins = FindViewById<Button>(Resource.Id.insertBtn);
            _result = FindViewById<TextView>(Resource.Id.resultText);
            _treeText = FindViewById<TextView>(Resource.Id.treePrint);
            _reset = FindViewById<Button>(Resource.Id.reset);
            // the three different printing buttons
            _preorder = FindViewById<Button>(Resource.Id.preOrderBtn);
            _inorder = FindViewById<Button>(Resource.Id.inOrderBtn);
            _postorder = FindViewById<Button>(Resource.Id.postOrderBtn);
            
            //lambda expressions for button click listeners
            
            // method invoked when user clicks on insert button
            _ins.Click += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(_input.Text))
                {
                    int toTree =int.Parse(_input.Text);
                    _tree.Insert(toTree);
                    _input.Text = null;
                    _toast = Toast.MakeText(this, $"{_input.Text} inserted successfully", ToastLength.Short);
                }
                else
                {
                    _toast = Toast.MakeText(this, "please type a value first", ToastLength.Short);
                    _toast.Show();
                }
                
            };

            // method invoked when user clicks on "clear tree" button
            _reset.Click += (sender, args) =>
            {
                // hides the textViews so the user focuses on only inserting methods until commanded to print the tree again.
                _result.Visibility = ViewStates.Invisible;
                _treeText.Visibility = ViewStates.Invisible;
                _treeText.Text = "";
                
                _tree = new BinaryTree();
                _toast = Toast.MakeText(this, "tree content cleared", ToastLength.Short);
                _toast.Show();
            };

            
            // method invoked when user clicks on preOrder tree-printing
            _preorder.Click += (sender, args) =>
            {
                try
                {
                    // sets the textViews to visible so the user sees the resulting tree
                    _result.Visibility = ViewStates.Visible;
                    _treeText.Visibility = ViewStates.Visible;
                    
                    string printedTree = _tree.PreOrder();
                    // removes the last two characters from the print result (which are ", ")
                    printedTree = printedTree.Substring(0, printedTree.Length - 2);
                    _treeText.Text = $"[{printedTree}]";
                
                    //Dismiss keyboard
                    InputMethodManager imm = (InputMethodManager)GetSystemService(InputMethodService);
                    imm.HideSoftInputFromWindow(_preorder.WindowToken, 0);
                
                    _toast = Toast.MakeText(this, "showing tree in PreOrder traversal", ToastLength.Short);
                    _toast.Show();
                }
                catch (Exception e)
                {
                    _toast = Toast.MakeText(this, "you must first insert an element", ToastLength.Short);
                    _toast.Show();
                }
                
            };

            _inorder.Click += (sender, args) =>
            {
                try
                {
                    // sets the textViews to visible so the user sees the resulting tree
                    _result.Visibility = ViewStates.Visible;
                    _treeText.Visibility = ViewStates.Visible;
                    
                    string printedTree = _tree.InOrder();
                    // removes the last two characters from the print result (which are ", ")
                    printedTree = printedTree.Substring(0, printedTree.Length - 2);
                    _treeText.Text = $"[{printedTree}]";
                
                    //Dismiss keyboard
                    InputMethodManager imm = (InputMethodManager)GetSystemService(InputMethodService);
                    imm.HideSoftInputFromWindow(_preorder.WindowToken, 0);
                
                    _toast = Toast.MakeText(this, "showing tree in InOrder traversal", ToastLength.Short);
                    _toast.Show();
                }
                catch (Exception e)
                {
                    _toast = Toast.MakeText(this, "you must first insert an element", ToastLength.Short);
                    _toast.Show();
                }
                
            };

            _postorder.Click += (sender, args) =>
            {
                try
                {
                    // sets the textViews to visible so the user sees the resulting tree
                    _result.Visibility = ViewStates.Visible;
                    _treeText.Visibility = ViewStates.Visible;
                    
                    string printedTree = _tree.PostOrder();
                    // removes the last two characters from the print result
                    printedTree = printedTree.Substring(0, printedTree.Length - 2);
                    _treeText.Text = $"[{printedTree}]";
                
                    //Dismiss keyboard
                    InputMethodManager imm = (InputMethodManager)GetSystemService(InputMethodService);
                    imm.HideSoftInputFromWindow(_preorder.WindowToken, 0);
                
                    _toast = Toast.MakeText(this, "showing tree in PostOrder traversal", ToastLength.Short);
                    _toast.Show();
                }
                catch (Exception e)
                {
                    _toast = Toast.MakeText(this, "you must first insert an element", ToastLength.Short);
                    _toast.Show();
                }
            };
        }
    }
}