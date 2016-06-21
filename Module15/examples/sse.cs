public ActionResult Message() 
{
  var result = string.Empty;
  var sb = new StringBuilder();
  if (_data.TryTake(out result, TimeSpan.FromMilliseconds(1000)))
  {
    JavaScriptSerializer ser = new JavaScriptSerializer();
    var serializedObject = ser.Serialize(new { item = result, message = "hello" });
    sb.AppendFormat("data: {0}\n\n", serializedObject);
  }
  return Content(sb.ToString(), "text/event-stream");
}