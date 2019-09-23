using GraphQL.Types;
using StepChallenge.DataModels;

namespace Model.GraphQL
{
    public class LeaderBoardType : ObjectGraphType<LeaderBoard>
    {
        public LeaderBoardType()
        {
            Name = "LeaderBoard";
            
            Field(x => x.TeamScores , type: typeof(ListGraphType<TeamScoreType>)).Description("The users steps");
            
        }
        
    }
}