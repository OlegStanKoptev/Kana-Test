using Foundation;
using System;
using UIKit;

namespace KanaTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            SymbolChecker.UseNumbers();
            Symbol.Text = SymbolChecker.NewSymbol();
            InputText.Text = "";
            StatusImage.Hidden = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void EditingDidEnd(UITextField sender)
        {
            if (SymbolChecker.CheckInput(Symbol.Text, InputText.Text))
            {
                Symbol.Text = SymbolChecker.NewSymbol();
                InputText.Text = "";
                StatusImage.Hidden = true;
                Score.Text = (int.Parse(Score.Text) + 1).ToString();
                if (int.Parse(Score.Text) > int.Parse(BestScore.Text)) BestScore.Text = Score.Text;
            }
            else
            {
                if (InputText.Text.Length >= SymbolChecker.NeededLength(Symbol.Text))
                {
                    StatusImage.Hidden = false;
                    Score.Text = 0.ToString();
                }
                else { StatusImage.Hidden = true; }
            }
        }

        partial void TouchUpInside(UIButton sender)
        {
            SymbolChecker.Change();
            Symbol.Text = SymbolChecker.NewSymbol();
        }

        partial void DismissKeyboard(UITextField sender)
        {
            InputText.ResignFirstResponder();
        }
    }
}