using DevExpress.XtraEditors;
using NukaCollect.Helpers;
using System.ComponentModel;

namespace NukaCollect.Win
{
    public class VisualBackgroundWorker : ProgressBarControl, IBackgroundWorker
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private int reportedProgress;

        public event DoWorkEventHandler DoWork;

        public event RunWorkerCompletedEventHandler RunWorkerCompleted;

        public event ProgressChangedEventHandler ProgressChanged;

        public VisualBackgroundWorker()
            : base()
        {
            InitializeBackgroundWorker();
            reportedProgress = this.Position;
        }

        public bool CancellationPending { get { return worker.CancellationPending; } }
        public bool IsBusy { get { return worker.IsBusy; } }

        [DefaultValue(true)]
        public bool WorkerReportsProgress
        {
            get { return worker.WorkerReportsProgress; }
            set { worker.WorkerReportsProgress = value; }
        }

        [DefaultValue(false)]
        public bool WorkerSupportsCancellation
        {
            get { return worker.WorkerSupportsCancellation; }
            set { worker.WorkerSupportsCancellation = value; }
        }

        public void CancelAsync()
        {
            worker.CancelAsync();
        }

        public void ReportProgress(int percentProgress)
        {
            if (percentProgress <= reportedProgress) return;
            reportedProgress = percentProgress;
            worker.ReportProgress(reportedProgress);
        }

        public void ReportProgress(int percentProgress, object userState)
        {
            if (percentProgress <= reportedProgress) return;
            reportedProgress = percentProgress;
            worker.ReportProgress(reportedProgress, userState);
        }

        public void RunWorkerAsync()
        {
            this.Position = reportedProgress = this.Properties.Minimum;
            worker.RunWorkerAsync();
        }

        public void RunWorkerAsync(object argument)
        {
            this.Position = reportedProgress = this.Properties.Minimum;
            worker.RunWorkerAsync(argument);
        }

        public int ReportedProgress { get { return reportedProgress; } }

        private void InitializeBackgroundWorker()
        {
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (DoWork != null) DoWork(this, e);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Position = reportedProgress = this.Properties.Maximum;
            if (RunWorkerCompleted != null) RunWorkerCompleted(this, e);
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Position = e.ProgressPercentage;
            if (ProgressChanged != null) ProgressChanged(this, e);
        }
    }
}