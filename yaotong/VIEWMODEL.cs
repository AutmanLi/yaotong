
//using MahApps.Metro.Controls.Dialogs;

//namespace yaotong
//{
//    public class VIEWMODEL : ViewModelBase
//    {
//         Variable
//        private IDialogCoordinator dialogCoordinator;

//         Constructor
//        public VIEWMODEL(IDialogCoordinator instance)
//        {
//            dialogCoordinator = instance;
//        }

//         Methods
//        private void FooMessage()
//        {
//            await dialogCoordinator.ShowMessageAsync(this, "HEADER", "MESSAGE");
//        }

//        private void FooProgress()
//        {
//             Show...
//            ProgressDialogController controller = await dialogCoordinator.ShowProgressAsync(this, "HEADER", "MESSAGE");
//            controller.SetIndeterminate();

//             Do your work... 

//             Close...
//            await controller.CloseAsync();
//        }

//         Actions... (ICommands for your view)
//    }
//}