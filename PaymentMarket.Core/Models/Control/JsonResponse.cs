namespace PaymentMarket.Core.Models.Control
{
    public class JsonResponse
    {
        //[JsonProperty("data")]
        public object Data { set; get; }

        //[JsonProperty("result")]
        public bool Result { get; set; }

       // [JsonProperty("control")]
        public JsonControl Control { get; set; }
        
        public JsonResponse()
        {
            Control = new JsonControl();
            Data = null;
            Result = false;
            Control.Code = "400";
            Control.Message = "Fue imposible realizar el consumo del Api";
          //  Control.Alert_Type = EnumToString(Tipo_Alerta.danger);
        }
        
        public enum Http_Code
        {
            [EnumToString("200")]
            Ok,
            [EnumToString("201")]
            Created,
            [EnumToString("202")]
            Accepted,
            [EnumToString("400")]
            BadRequest,
            [EnumToString("404")]
            NotFound,
        }

        
        
    }
}