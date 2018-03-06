namespace CodesGenerationJSON
{
    public class Error
    {
        private int id;
        private string code;
        private string description;
        private string explanation;
        private string system_action;
        private string programmer_response;
        private string sql_state;
        private int searchs;
        private string note;

        public Error()
        {
            this.code = "";
            this.description = "";
            this.explanation = "";
            this.system_action = "";
            this.programmer_response = "";
            this.sql_state = "";
            this.note = "";
        }

		public Error(int id, string code, string description, string explanation, string sys_action, string programer_resp, 
            string sql_s, string note)
        {
            this.id = id;
            this.code = code;
            this.description = description;
            this.explanation = explanation;
            this.system_action = sys_action;
            this.programmer_response = programer_resp;
            this.sql_state = sql_s;
            this.searchs = 0;
            this.note = note;
        }

        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public string Explanation { get => explanation; set => explanation = value; }
        public string System_action { get => system_action; set => system_action = value; }
        public string Programmer_response { get => programmer_response; set => programmer_response = value; }
        public string Sql_state { get => sql_state; set => sql_state = value; }
        public int Searchs { get => searchs; set => searchs = value; }
        public string Note { get => note; set => note = value; }
    }
}
