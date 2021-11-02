using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ToDoWebClient.Models
{
    public class ToDo
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("id"), Key] public int TodoId { get; set; }

        [Required, MaxLength(128)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("completed"), Required]
        public bool IsCompleted { get; set; }
    }
}