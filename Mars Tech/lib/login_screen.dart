import 'package:flutter/material.dart';
import 'constants.dart'; // Ensure you have the constants defined
// ignore: library_prefixes
import 'sign_up.dart' as signUp; // Alias for SignUpScreen
import 'forgot_password.dart'
    // ignore: library_prefixes
    as forgotPassword; // Alias for ForgotPasswordScreen
// Import the LMS Page after login
import 'lms_page.dart';

class LoginScreen extends StatefulWidget {
  const LoginScreen({super.key});

  static const String forgotPasswordText = "Forgot Password?";

  @override
  // ignore: library_private_types_in_public_api
  _LoginScreenState createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final String _validEmail = "user@example.com"; // Example email
  final String _validPassword = "password123"; // Example password
  bool _isLoading = false; // To show loading indicator
  bool _isPasswordVisible = false; // To toggle password visibility

  void _login() {
    String email = _emailController.text.trim();
    String password = _passwordController.text.trim();

    // Input validation
    if (email.isEmpty) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Email is required")),
      );
      return;
    }
    if (password.isEmpty) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Password is required")),
      );
      return;
    }

    setState(() {
      _isLoading = true; // Show loading indicator
    });

    // Simulate a network call or authentication process
    Future.delayed(const Duration(seconds: 2), () {
      setState(() {
        _isLoading = false; // Hide loading indicator
      });

      if (email == _validEmail && password == _validPassword) {
        // If credentials match, navigate to the LMS page
        Navigator.push(
          // ignore: use_build_context_synchronously
          context,
          MaterialPageRoute(
            builder: (context) => const LMSPage(),
          ),
        );
      } else {
        // Show an error if credentials do not match
        // ignore: use_build_context_synchronously
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text("Invalid email or password")),
        );
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    final double height = MediaQuery.of(context).size.height;
    final double width = MediaQuery.of(context).size.width;

    return Scaffold(
      body: Stack(
        children: [
          // Background Image
          Container(
            height: height * 0.35, // 35% of screen height
            width: width,
            decoration: BoxDecoration(
              image: DecorationImage(
                image: AssetImage(bgImage), // bgImage from constants
                fit: BoxFit.cover,
              ),
            ),
          ),

          // Gradient Overlay for Smooth Fade
          Container(
            height: height * 0.35, // Match background image height
            width: width,
            decoration: BoxDecoration(
              gradient: LinearGradient(
                begin: Alignment.bottomCenter,
                end: Alignment.topCenter,
                colors: [
                  Colors.white,
                  Color.fromRGBO(255, 255, 255, 0.2),
                  Color.fromRGBO(255, 255, 255, 0.0),
                ],
              ),
            ),
          ),

          // Content
          SingleChildScrollView(
            child: Padding(
              padding: EdgeInsets.only(
                  top: height * 0.32), // Adjust for image overlap
              child: Column(
                children: [
                  // App Title
                  Text(
                    appName,
                    style: const TextStyle(
                      fontSize: 28,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  const SizedBox(height: 5),
                  Text(
                    slogan,
                    style: const TextStyle(fontSize: 16, color: Colors.grey),
                  ),
                  const SizedBox(height: 30),

                  // LOGIN FORM
                  Padding(
                    padding: const EdgeInsets.symmetric(horizontal: 20),
                    child: Column(
                      children: [
                        Align(
                          alignment: Alignment.centerLeft,
                          child: Text(
                            loginTitle,
                            style: const TextStyle(
                                fontSize: 20, fontWeight: FontWeight.bold),
                          ),
                        ),
                        const SizedBox(height: 10),
                        TextField(
                          controller: _emailController,
                          decoration: InputDecoration(
                            labelText: emailHint,
                            prefixIcon: const Icon(Icons.email,
                                color: Color.fromARGB(255, 124, 33, 243)),
                            border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10),
                            ),
                          ),
                        ),
                        const SizedBox(height: 15),
                        TextField(
                          controller: _passwordController,
                          obscureText: !_isPasswordVisible,
                          decoration: InputDecoration(
                            labelText: passwordHint,
                            prefixIcon: const Icon(Icons.lock,
                                color: Color.fromARGB(255, 124, 33, 243)),
                            suffixIcon: IconButton(
                              icon: Icon(
                                _isPasswordVisible
                                    ? Icons.visibility
                                    : Icons.visibility_off,
                                color: Colors.grey,
                              ),
                              onPressed: () {
                                setState(() {
                                  _isPasswordVisible = !_isPasswordVisible;
                                });
                              },
                            ),
                            border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10),
                            ),
                          ),
                        ),
                        const SizedBox(height: 10),
                        Align(
                          alignment: Alignment.centerRight,
                          child: TextButton(
                            onPressed: () {
                              // Navigate to Forgot Password screen
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (context) => const forgotPassword
                                      .ForgotPasswordScreen(),
                                ),
                              );
                            },
                            child: Text(
                              forgotPasswordText,
                              style: const TextStyle(color: Colors.grey),
                            ),
                          ),
                        ),
                        const SizedBox(height: 15),
                        SizedBox(
                          width: double.infinity,
                          height: 50,
                          child: ElevatedButton(
                            style: ElevatedButton.styleFrom(
                              backgroundColor:
                                  const Color.fromARGB(255, 124, 33, 243),
                              shape: RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(10),
                              ),
                            ),
                            onPressed: _isLoading ? null : _login,
                            child: _isLoading
                                ? const CircularProgressIndicator(
                                    color: Colors.white,
                                  )
                                : Text(
                                    loginButtonText, // Defined in constants
                                    style: const TextStyle(
                                        color: Colors.white, fontSize: 16),
                                  ),
                          ),
                        ),
                        const SizedBox(height: 20),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Text(signUpPromptText),
                            TextButton(
                              onPressed: () {
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) =>
                                        const signUp.SignUpScreen(),
                                  ),
                                );
                              },
                              child: Text(
                                signUpText, // Defined in constants
                                style: const TextStyle(
                                  color: Color.fromARGB(255, 124, 33, 243),
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
