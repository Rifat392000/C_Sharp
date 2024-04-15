public class CustomException : ApplicationException
  {
    string _message;

public CustomException(string message){

_message = message;

}
    public override string Message
    {
        get
        {
            return _message;
        }
       
    }
  }  