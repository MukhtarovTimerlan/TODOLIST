namespace TODOLIST.Models
{
    public class Request
    {
        public int id { get; set; }
       
        public int PersonId { get; set; }

        public RequestData RequestData { get; set; }

        public Request ()
        {

        }

        public Request(int id, string Title, string Description, int PersonId, int StatusId)
        {
            this.id = id;
            this.RequestData = new RequestData
            {
                id = id,
                Title = Title,
                Description = Description,
                StatusId = StatusId,
                AddData = DateTime.Now,
                ChangeData = DateTime.Now
            };
            this.PersonId = PersonId;
        }
    }
}
