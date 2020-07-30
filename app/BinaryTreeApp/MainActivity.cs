using Android.App;
using Android.OS;
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
        private TextView _result;
        private TextView _treeText;
        private bool _printed;
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
            // the three different printing buttons
            _preorder = FindViewById<Button>(Resource.Id.preOrderBtn);
            _inorder = FindViewById<Button>(Resource.Id.inOrderBtn);
            _postorder = FindViewById<Button>(Resource.Id.postOrderBtn);
            
            //lambda expressions for button click listeners
            _ins.Click += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(_input.Text))
                {
                    if (!_printed)
                    {
                        int toTree =int.Parse(_input.Text);
                        _tree.Insert(toTree);
                        _input.Text = null;
                    }
                    _tree = new BinaryTree();
                    int toTree1 =int.Parse(_input.Text);
                    _tree.Insert(toTree1);
                    _input.Text = null;
                    _printed = false;
                }
                else
                {
                    _toast = Toast.MakeText(this, "please type a value first", ToastLength.Short);
                    _toast.Show();
                }
                
            };

            _preorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                
                string printedTree = _tree.PreOrder();
                _treeText.Text = $"[ {printedTree}]";
                _toast = Toast.MakeText(this, "showing tree in PreOrder traversal", ToastLength.Short);
                _toast.Show();
            };

            _inorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                string printedTree = _tree.InOrder();
                _treeText.Text = $"[ {printedTree}]";
                _toast = Toast.MakeText(this, "showing tree in InOrder traversal", ToastLength.Short);
                _toast.Show();
            };

            _postorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                string printedTree = _tree.PostOrder();
                _treeText.Text = $"[ {printedTree}]";
                _toast = Toast.MakeText(this, "showing tree in PostOrder traversal", ToastLength.Short);
                _toast.Show();
            };
        }
    }
}