import 'package:flutter/material.dart';

class ForgotPasswordScreen extends StatelessWidget {
  const ForgotPasswordScreen({super.key});

  @override
  Widget build(BuildContext context) {
    final double height = MediaQuery.of(context).size.height;
    final double width = MediaQuery.of(context).size.width;

    return Scaffold(
      body: Stack(
        children: [
          // Background Image
          Container(
            height: height * 0.40, // 35% of screen height
            width: width,
            decoration: BoxDecoration(
              image: DecorationImage(
                image: AssetImage(
                    'assets/ethical hacking.png'), // Ensure this path is correct
                fit: BoxFit.cover,
              ),
            ),
          ),

          // Gradient Overlay for Smooth Fade
          Container(
            height: height * 0.40, // Match background image height
            width: width,
            decoration: BoxDecoration(
              gradient: LinearGradient(
                begin: Alignment.bottomCenter,
                end: Alignment.topCenter,
                colors: [
                  Color.fromRGBO(255, 255, 255, 0.5), // White with 50% opacity
                  Color.fromRGBO(255, 255, 255, 0.0), // Fully transparent
                ],
              ),
            ),
          ),

          // Main content wrapped in SingleChildScrollView
          SingleChildScrollView(
            child: Padding(
              padding: EdgeInsets.only(
                  top: height * 0.32), // Adjust for image overlap
              child: Column(
                children: [
                  const SizedBox(height: 10),
                  const Text(
                    "Forgot Password",
                    style: TextStyle(
                      fontSize: 28,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  const SizedBox(height: 10),
                  const Text(
                    "Enter your email to reset your password.",
                    style: TextStyle(fontSize: 16, color: Colors.grey),
                    textAlign: TextAlign.center,
                  ),
                  const SizedBox(height: 40),
                  Padding(
                    padding: const EdgeInsets.symmetric(horizontal: 20),
                    child: TextField(
                      decoration: InputDecoration(
                        labelText: 'Email',
                        prefixIcon: Icon(Icons.email),
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(10),
                        ),
                      ),
                    ),
                  ),
                  const SizedBox(height: 30),
                  Padding(
                    padding: const EdgeInsets.symmetric(horizontal: 20),
                    child: SizedBox(
                      width: double.infinity,
                      height: 50,
                      child: ElevatedButton(
                        onPressed: () {
                          // Logic to send reset instructions
                        },
                        child: const Text("Send Reset Instructions"),
                      ),
                    ),
                  ),
                  const SizedBox(height: 20),
                  TextButton(
                    onPressed: () {
                      Navigator.pop(context); // Navigate back to login screen
                    },
                    child: const Text("Back to Login"),
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
