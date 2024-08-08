// tabs
$('#login-form #tab-register').click(function () {

	$('#login-form').fadeToggle();
	$(".form-background").animate(
		{
			"top": "-342px",
			"width": "400px",
			"height": "410px"
		},
		"slow", function () {
			$('#register-form').fadeToggle();
		});
});

$('#register-form #tab-login').click(function () {

	$('#register-form').fadeToggle();
	$(".form-background").animate(
		{
			"top": "-214px",
			"width": "400px",
			"height": "290px"
		},
		"slow", function () {
			$('#login-form').fadeToggle();
		});
});

// Tips
$('#register-form .email-tip-icon').hover(function () {
	$('#message-email').fadeToggle();
});

$('#register-form .password-tip-icon').hover(function () {
	$('#message-password').fadeToggle();
});