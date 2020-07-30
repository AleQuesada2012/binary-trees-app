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
                int toTree =int.Parse(_input.Text);
                //TODO create insertion method in BST class
                _tree.Insert(toTree);
            };

            _preorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                // TODO code preorder method in BST class
                _treeText.Text = $"[ {_tree.Preorder} ]";
            };

            _inorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                // TODO code inorder method in BST class
                _treeText.Text = $"[ {_tree.Inorder} ]";
            };

            _postorder.Click += (sender, args) =>
            {
                _printed = true;
                _result.Visibility = ViewStates.Visible;
                _treeText.Visibility = ViewStates.Visible;
                // TODO code postorder method in BST class
                _treeText.Text = $"[ {_tree.Postorder} ]";
            };
        }
    }
}