namespace mis_321_pa5_hrwalls_crimson
{
public interface IAction
{
    //Exceedingly simple interface for actions to inherit from.
    void ActionTaken(Player actor, Player target);
}
}