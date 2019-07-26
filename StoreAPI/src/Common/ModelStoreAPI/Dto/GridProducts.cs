using System;
using System.Collections.Generic;

namespace ModelStoreAPI.Dto
{
    public class GridProducts
    {
        public string SortBy { get; set; }
        public bool Descending { get; set; }
        public int RowsPerPage { get; set; }
        public int Page { get; set; }
        public Dictionary<string, string> Filter { get; set; }

        private DataGridResponse DataResponse = new DataGridResponse();

        public void Initialize()
        {
            /* Amount of registers per page */
            Page = Page - 1;

            /* From wich page number?*/
            if (Page > 0) Page = Page * RowsPerPage;
        }

        public void SetData(dynamic data, int total)
        {
            DataResponse = new DataGridResponse
            {
                Data = data,
                Total = total
            };
        }

        public DataGridResponse Response()
        {
            return DataResponse;
        }
    }

    public class DataGridResponse
    {
        public int Total { get; set; }
        public dynamic Data { get; set; }
    }
}
