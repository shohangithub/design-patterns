using Stratrgy_Solution.Concrete_Strategy;
using Stratrgy_Solution.Context;

PaymentGateway paymentGateway = new();

// implement payment with bkash
paymentGateway.Payment(new BkashPaymentGateway());

// implement payment with nagad
paymentGateway.Payment(new NagadPaymentGateway());

// implement payment with ROCKET
paymentGateway.Payment(new RocketPaymentGateway());



//what happen if we want to add UPAY

/*
 
    - it is not violeting open close priciple
    - doesn't need to change existing code
    - can't have chance arise bug prevous code
    - so on ....
    - here is the soltion.. we can resolve it implement stategy pattern

 */

paymentGateway.Payment(new UpayPaymentGateway());