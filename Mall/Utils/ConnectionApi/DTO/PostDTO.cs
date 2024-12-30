namespace Mall.Utils.ConnectionApi.DTO
{
    class PostDTO<T>
    {
        public Dictionary<string, string>? header { get; set; } = null;
        public T Content { get; set; }
    }
}
