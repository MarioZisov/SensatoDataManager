namespace SensatoClient.Presenters
{
    using Contracts;
    using Models;
    using SensatoServiceReference;

    public class HivePresenter : AbstractPresenter
    {
        private IHiveView hiveView;
        private SensatoServiceClient serviceClient;

        //Hive presenters must hold Previous, Current and Next view.
        public HivePresenter(IHiveView hiveView)
        {
            this.hiveView = hiveView;
            this.serviceClient = new SensatoServiceClient();
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
        }
        public void LoadHives()
        {
            var hivesDto = this.serviceClient.GetHivesByUser(this.User.Username);
            foreach (var hiveDto in hivesDto)
            {
                HiveModel hive = new HiveModel();
                if (!hiveDto.IsRemoved)
                {
                    hive.Id = hiveDto.Id;
                    hive.Name = hiveDto.Name;
                    foreach (var frameDto in hiveDto.Frames)
                    {
                        FrameModel frame = new FrameModel();
                        if (!frameDto.IsRemoved)
                        {
                            frame.Position = frameDto.Position;
                            hive.Frames.Add(frame);
                        }
                    }
                    this.User.Hives.Add(hive);
                }
            }

            this.PassHivesToView();
        }

        private void PassHivesToView()
        {
            
        }
    }
}