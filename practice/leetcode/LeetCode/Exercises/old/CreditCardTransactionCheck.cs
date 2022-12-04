namespace Exercises.old;

public class CreditCardTransactionCheck
{
    private int _balance = 1000;
    private int _limit = 1000;

    private Dictionary<int, AuthOperation> authHistory = new Dictionary<int, AuthOperation>();

    public int Calculate(List<Transaction> transactions)
    {
        // returns 1 - OK
        // returns 0 -- not ok
        int result = 0;
        foreach (Transaction transaction in transactions)
        {
            switch (transaction.Operation)
            {
                case CreditCardOperation.Auth:
                    MaintainAuthHistory();
                    result = DetermineAuthValidity(transaction);
                    break;

                case CreditCardOperation.Capture:
                    MaintainAuthHistory();
                    result = DetermineCaptureValidity(transaction);
                    break;

                default:
                    // error
                    break;
            }
        }

        return result;
    }

    private int DetermineCaptureValidity(Transaction transaction)
    {
        if (authHistory.ContainsKey(transaction.HoursOrTransactionId))
        {
            AuthOperation authOperation = authHistory[transaction.HoursOrTransactionId];
            if (authOperation.Amount <= transaction.Amount)
            {
                _balance += authOperation.Amount - transaction.Amount;
                authHistory.Remove(transaction.HoursOrTransactionId);
                return 1;
            }
        }

        return 0;
    }
    
    private int DetermineAuthValidity(Transaction transaction)
    {
        if (transaction.Amount > _limit)
        {
            return 0;
        }
        
        if (transaction.Amount > _balance)
        {
            return 0;
        }

        _balance -= transaction.Amount;
        AuthOperation authOperation = new AuthOperation
        {
            Amount = transaction.Amount,
            Hours = transaction.HoursOrTransactionId,
            OperationDateTime = transaction.DateTime
        };
        authHistory.Add(transaction.Id, authOperation);
        return 1;
    }

    private void MaintainAuthHistory()
    {
        // removes auth operations not effect anymore
        if (authHistory.Any())
        {
            for (int i = 0; i < authHistory.Count; i++)
            {
                AuthOperation singleOperation = authHistory[i];
                DateTime operationValidUntil = singleOperation.OperationDateTime.AddHours(singleOperation.Hours);
                if (operationValidUntil < DateTime.Now)
                {
                    authHistory.Remove(i);
                    _balance += singleOperation.Amount;
                }
            }
        }
    }

    public class AuthOperation
    {
        public DateTime OperationDateTime { get; set; }
        public int Amount { get; set; }
        public int Hours { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Operation { get; set; }
        public int Amount { get; set; }
        public int HoursOrTransactionId { get; set; }
    }

    public static class CreditCardOperation
    {
        public const string Auth = "AUTH";
        public const string Capture = "CAPTURE";
    }
}