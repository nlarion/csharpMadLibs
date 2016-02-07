using Nancy;
using Madlib.Objects;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/story"] = _ => {
        StoryVariables myStoryVariables = new StoryVariables 
        {
          Person1 = Request.Query["person1"],
          Person2 = Request.Query["person2"],
          Animal = Request.Query["animal"],
          Exclamation = Request.Query["exclamation"],
          Verb = Request.Query["verb"],
          Noun = Request.Query["noun"]
        };
        return View["story.html", myStoryVariables];
      };
    }
  }
}