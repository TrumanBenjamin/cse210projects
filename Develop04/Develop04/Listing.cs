using System;

class Listing : Activity
{
    private string[] _prompts;
    private string[] _userList;

    public Listing(int duration, string spinner, string description, string response, string[] prompts, string[] userList)
        : base(duration, spinner, description, response)
        {
            _prompts = prompts;
            _userList = userList;
        }

}