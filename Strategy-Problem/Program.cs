using Strategy_Problem;


PaymentGateway paymentGateway = new();

// implement payment with bkash
paymentGateway.Payment("BKASH");

// implement payment with nagad
paymentGateway.Payment("NAGAD");

// implement payment with ROCKET
paymentGateway.Payment("ROCKET");

//what happen if we want to add UPAY
/*
 
    - it's violet open close priciple
    - need to change existing code
    - can be arise bug
    - so on ....
    - here is problem.. we can resolve it implement stategy pattern

 */

//.....paymentGateway.Payment("UPAY");