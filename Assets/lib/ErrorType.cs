namespace FlexError {
    public class ErrorType {
        public class DetailedError : ErrorType {
            public string Description { get; set; }
            public string Details { get; set; }
            public override string ToString() {
                return $"DetailedError: {Description}, Details: {Details}";
            }
        }
        public class SimpleError : ErrorType {
            public string Message { get; set; }
        }
    }
}
