redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51IuZTULjHP9VtxkS8sqmlLzWmiB66yLi7CCVqHhfKJr7AlWoxyjQI14uzqe69G9eKYeJb2vONsJLomIStkbIl7hE00WXmhYdEr');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
};