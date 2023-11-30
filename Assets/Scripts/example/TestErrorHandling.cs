using UnityEngine;
using FlexError;
public class TestErrorHandling : MonoBehaviour
{
    void Start()
    {
        var result = check_condition(new Condition());

        if (!result.IsSuccess) {
            Debug.LogError("Error occurred: " + result.Error.ToString());
        } else {
            Debug.Log("Condition check succeeded.");
        }
    }
    private Result<Void> check_condition(Condition condition){
        // return error
        return Result<Void>.Fail(new ErrorType.DetailedError {
            Description = "test error",
            Details = "Certain conditions were not met."
        });
    }
}

// test class
public class Condition
{
}

public class Void
{
    public static readonly Void Value = new Void();
}

