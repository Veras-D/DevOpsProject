# Test Cases - Tarot Card Reader Application

## Functional Test Cases

### TC-F001: Draw Random Card
**Description**: Verify that the application can draw a random Tarot card
**Preconditions**: Application is launched
**Steps**:
1. Click the "Draw Card" button
2. Observe the displayed card
**Expected Result**: A random Tarot card is displayed with its image and name
**Status**: Ready for testing

### TC-F002: Verify Card Range
**Description**: Verify that all cards in the range 0-21 can be drawn
**Preconditions**: Application is launched
**Steps**:
1. Click the "Draw Card" button multiple times (at least 50 times)
2. Record the drawn cards
**Expected Result**: Cards from across the range 0-21 are drawn, confirming the randomization works
**Status**: Ready for testing

### TC-F003: Verify Card Information
**Description**: Verify that card information is correctly displayed
**Preconditions**: Application is launched, a card is drawn
**Steps**:
1. Observe the displayed card image
2. Observe the displayed card name
**Expected Result**: The card name format should be "{ID} - {Name}" and the image should match the card
**Status**: Ready for testing

## UI Test Cases

### TC-U001: Verify Dark Mode
**Description**: Verify that the application UI follows the dark mode theme
**Preconditions**: Application is launched
**Steps**:
1. Observe the application window background
2. Observe the text color
3. Observe the button styling
**Expected Result**: The application uses dark backgrounds, light text, and appropriate button styling for dark mode
**Status**: Ready for testing

### TC-U002: Verify Window Resizing
**Description**: Verify that the application UI handles window resizing properly
**Preconditions**: Application is launched
**Steps**:
1. Resize the application window to various dimensions
2. Observe how the UI elements adjust
**Expected Result**: UI elements should remain properly aligned and visible at various window sizes
**Status**: Ready for testing

## Error Handling Test Cases

### TC-E001: Missing Card Image
**Description**: Verify handling of missing card images
**Preconditions**: Application is launched, one image file is temporarily renamed
**Steps**:
1. Click the "Draw Card" button until the card with the missing image is drawn
**Expected Result**: The application displays a default image (verso.png) or handles the error gracefully
**Status**: Ready for testing

## Performance Test Cases

### TC-P001: Application Launch Time
**Description**: Verify the application launches within an acceptable time frame
**Preconditions**: None
**Steps**:
1. Time how long it takes for the application to launch fully
**Expected Result**: Application launches in under 3 seconds
**Status**: Ready for testing

## Compatibility Test Cases

### TC-C001: Windows Compatibility
**Description**: Verify the application runs properly on Windows
**Preconditions**: Windows machine with .NET 8.0.114 installed
**Steps**:
1. Install and launch the application
2. Perform basic functionality tests
**Expected Result**: Application functions correctly on Windows
**Status**: Ready for testing

### TC-C002: Linux Compatibility
**Description**: Verify the application runs properly on Linux
**Preconditions**: Linux machine with .NET 8.0.114 installed
**Steps**:
1. Install and launch the application
2. Perform basic functionality tests
**Expected Result**: Application functions correctly on Linux
**Status**: Ready for testing

### TC-C003: Docker Compatibility
**Description**: Verify the application runs properly in Docker
**Preconditions**: Docker installed
**Steps**:
1. Build the Docker image
2. Run the Docker container
**Expected Result**: Application can be built and run in Docker
**Status**: Ready for testing
