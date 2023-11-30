namespace FlexError {
    public class Result<T> {
        public T Value { get; private set; }
        public ErrorType Error { get; private set; }
        public bool IsSuccess { get; private set; }

        public static Result<T> Success(T value) {
            return new Result<T> { Value = value, IsSuccess = true };
        }

        public static Result<T> Fail(ErrorType error) {
            return new Result<T> { Error = error, IsSuccess = false };
        }
    }
}

