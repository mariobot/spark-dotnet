using Spark.Installer.Models;

namespace Spark.Installer.Wizard
{
    public class WizardModelcs
    {
        public string Title { get; set; } = "Spark Installer";
        public string Description { get; set; } = "Welcome to the Spark Installer. This wizard will guide you through the installation process.";
        public string NextButtonText { get; set; } = "Next";
        public string BackButtonText { get; set; } = "Back";
        public string CancelButtonText { get; set; } = "Cancel";
        public string FinishButtonText { get; set; } = "Finish";
        public string ErrorMessage { get; set; } = "An error occurred during the installation process.";
        public Theme Theme { get; set; } = new Theme();
    }
}
