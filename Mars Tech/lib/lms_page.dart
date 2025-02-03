import 'package:flutter/material.dart';
import 'cyber_security_page.dart';
import 'artificial_intelligence_page.dart'; // Importing ArtificialIntelligencePage

class LMSPage extends StatelessWidget {
  const LMSPage({super.key});

  // Course data with names and passwords
  static const Map<String, String> courses = {
    'Cyber Security': 'cyber123',
    'Artificial Intelligence': 'ai123',
  };

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('LMS Page'),
      ),
      body: ListView(
        children: courses.entries.map((entry) {
          final courseName = entry.key;
          return ListTile(
            leading: const Icon(Icons.lock, color: Colors.grey),
            title: Text(courseName),
            subtitle: const Text('Locked'),
            trailing: IconButton(
              icon: const Icon(Icons.arrow_forward),
              onPressed: () {
                _showCoursePasswordDialog(context, entry.value, courseName);
              },
            ),
          );
        }).toList(),
      ),
    );
  }

  // Dialog to enter password for each course
  void _showCoursePasswordDialog(
      BuildContext context, String correctPassword, String courseName) {
    TextEditingController passwordController = TextEditingController();
    bool isPasswordVisible = false;

    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Enter Password for $courseName'),
          content: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextField(
                controller: passwordController,
                obscureText: !isPasswordVisible,
                decoration: InputDecoration(
                  labelText: 'Password',
                  suffixIcon: IconButton(
                    icon: Icon(
                      isPasswordVisible
                          ? Icons.visibility
                          : Icons.visibility_off,
                      color: Colors.grey,
                    ),
                    onPressed: () {
                      // Toggle password visibility
                      isPasswordVisible = !isPasswordVisible;
                      (context as Element).markNeedsBuild();
                    },
                  ),
                ),
              ),
            ],
          ),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.pop(context);
              },
              child: const Text('Cancel'),
            ),
            TextButton(
              onPressed: () {
                String enteredPassword = passwordController.text.trim();
                if (enteredPassword.isEmpty) {
                  ScaffoldMessenger.of(context).showSnackBar(
                    const SnackBar(content: Text('Please enter a password')),
                  );
                  return;
                }
                if (enteredPassword == correctPassword) {
                  Navigator.pop(context);
                  _navigateToCoursePage(context, courseName);
                } else {
                  Navigator.pop(context);
                  _showErrorDialog(context);
                }
              },
              child: const Text('Submit'),
            ),
          ],
        );
      },
    );
  }

  // Navigate to the course page
  void _navigateToCoursePage(BuildContext context, String courseName) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text('Accessing $courseName course')),
    );
    if (courseName == 'Cyber Security') {
      // Navigate to Cyber Security Page when the correct password is entered for Cyber Security
      Navigator.push(
        context,
        MaterialPageRoute(builder: (context) => const CyberSecurityPage()),
      );
    } else if (courseName == 'Artificial Intelligence') {
      // Navigate to Artificial Intelligence Page when the correct password is entered for AI
      Navigator.push(
        context,
        MaterialPageRoute(
            builder: (context) => const ArtificialIntelligencePage()),
      );
    }
  }

  // Show an error dialog if the password is wrong
  void _showErrorDialog(BuildContext context) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Error'),
          content: const Text('Incorrect password. Please try again.'),
          actions: [
            TextButton(
              onPressed: () => Navigator.pop(context),
              child: const Text('OK'),
            ),
          ],
        );
      },
    );
  }
}
