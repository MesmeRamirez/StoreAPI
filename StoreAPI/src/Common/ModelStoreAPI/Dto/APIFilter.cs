namespace ModelStoreAPI
{
    public class APIFilter
    {
        public string Sort { get; set; }
        public bool Descending { get; set; }
        public string Filter { get; set; }

        //Pagination
        public int Take { get; set; }
        public int Page { get; set; }

        public APIFilter()
        {
            Take = 20;
        }
    }
}
