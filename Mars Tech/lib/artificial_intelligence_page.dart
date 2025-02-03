import 'package:flutter/material.dart';
import 'package:youtube_player_flutter/youtube_player_flutter.dart'; // Import the youtube_player_flutter package

class ArtificialIntelligencePage extends StatefulWidget {
  const ArtificialIntelligencePage({super.key});

  @override
  // ignore: library_private_types_in_public_api
  _ArtificialIntelligencePageState createState() =>
      _ArtificialIntelligencePageState();
}

class _ArtificialIntelligencePageState
    extends State<ArtificialIntelligencePage> {
  late YoutubePlayerController _controller;

  @override
  void initState() {
    super.initState();
    // Initialize the Youtube player controller with the YouTube video URL
    _controller = YoutubePlayerController(
      initialVideoId:
          '2ePf9rue1Ao', // Replace with your desired video ID from YouTube
      flags: const YoutubePlayerFlags(
        autoPlay:
            false, // Set to true if you want the video to start playing automatically
        mute: false, // Set to true if you want the video to be muted by default
      ),
    );
  }

  @override
  void dispose() {
    _controller.dispose(); // Dispose the controller to release resources
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Artificial Intelligence'),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: YoutubePlayer(
              controller: _controller,
              showVideoProgressIndicator: true, // Show the video progress bar
            ),
          ),
          const Padding(
            padding: EdgeInsets.all(8.0),
            child:
                Text('Some interesting facts about Artificial Intelligence.'),
          ),
        ],
      ),
    );
  }
}

void main() {
  runApp(const MaterialApp(
    home: ArtificialIntelligencePage(),
  ));
}
