using TaskFlow.Communication.Enums;

namespace TaskFlow.Communication.Requests.Tasks;

public class RequestRegisterTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description {  get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime DueDate { get; set; } //Data futura para conclusão da tarefa
    public StatusEnum Status { get; set; }

}
