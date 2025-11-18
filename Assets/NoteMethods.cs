
using Firebase;
using Firebase.Database;
using Firebase.Auth;
using System.Threading.Tasks;

public static class NoteMethods
{
    public static async Task<string> createUser() 
    {
        var task = await FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync();
        return task.User.UserId; // Return the userID 
    }

    public static async Task<string> getUser()
    {
        return await FirebaseAuth.DefaultInstance.CurrentUser.UserId;
    }

    public static async void createNote()
    {
        
    }

    public static async void editNote()
    {
        
    }

    public static async void deleteNote()
    {
        
    }
}