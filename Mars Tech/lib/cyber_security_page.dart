import 'package:flutter/material.dart';
import 'package:youtube_player_flutter/youtube_player_flutter.dart'; // Import the youtube_player_flutter package

class CyberSecurityPage extends StatefulWidget {
  const CyberSecurityPage({super.key});

  @override
  // ignore: library_private_types_in_public_api
  _CyberSecurityPageState createState() => _CyberSecurityPageState();
}

class _CyberSecurityPageState extends State<CyberSecurityPage> {
  late YoutubePlayerController _controller;

  @override
  void initState() {
    super.initState();
    _controller = YoutubePlayerController(
      initialVideoId: YoutubePlayer.convertUrlToId(
          'https://youtu.be/Qff4b_N3J4I')!, // Use the correct YouTube URL
      flags: const YoutubePlayerFlags(
        autoPlay: false,
        mute: false,
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Cyber Security'),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: YoutubePlayer(
              controller: _controller,
              showVideoProgressIndicator: true,
            ),
          ),
          const Padding(
            padding: EdgeInsets.all(8.0),
            child: Text('Some interesting facts about cyber security.'),
          ),
        ],
      ),
    );
  }

  @override
  void dispose() {
    super.dispose();
    _controller.dispose();
  }
}

void main() {
  runApp(const MaterialApp(
    home: CyberSecurityPage(),
  ));
}
