
class BankUser {
    int balance;
    public string name;
    public BankUser () {
        balance = 500;
    }
    
    public void SetBalance (int addAmount) {
        
        balance = balance + addAmount;
        
        return;
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