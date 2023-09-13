
class BankUser {
    int balance;
    public string name;
    public BankUser () {
        balance = 500;
    }
    
    public void AddBalance (int addAmount) {
        
        balance = balance + addAmount;
        
        return;
    }
    public void RemoveBalance (int removeAmount) {
        balance = balance - removeAmount;
    }

    public int GetBalance () {
        return balance;
    }
    public void SetName (string newName) {
        this.name = newName;
    }
    public string GetName () {
        return name;
    }
}