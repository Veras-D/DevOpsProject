# Manual and Exploratory Tests - Tarot Card Reader Application

## Manual Test Checklist

### Application Setup and Installation
- [ ] Verify that the application can be built from source on Windows
- [ ] Verify that the application can be built from source on Linux
- [ ] Verify that the application can be run from a pre-built binary on Windows
- [ ] Verify that the application can be run from a pre-built binary on Linux
- [ ] Verify that the Docker image can be built and run successfully

### UI and Visual Elements
- [ ] Verify that the window title is "Tarot Card Reader"
- [ ] Verify that the application icon appears correctly in the taskbar/dock
- [ ] Verify that all text is legible with the dark mode theme
- [ ] Verify that the card image is displayed with the correct proportions
- [ ] Verify that the "Draw Card" button has appropriate hover and click effects
- [ ] Verify that the UI is responsive and scales appropriately with window resizing

### Functionality
- [ ] Verify that clicking "Draw Card" changes the displayed card
- [ ] Verify over multiple draws that the randomization appears to be working
- [ ] Verify that card names are correctly displayed with the format "{ID} - {Name}"
- [ ] Verify that all 22 Major Arcana cards (0-21) can be drawn

### Error Handling
- [ ] Temporarily rename or remove an image file and verify the application handles it gracefully
- [ ] Run the application with limited system resources to verify stability
- [ ] Close and reopen the application multiple times to verify stability

## Exploratory Testing Sessions

### Session 1: General Usability (30 minutes)
**Charter**: Explore the general usability of the Tarot Card Reader application
**Areas to focus on**:
- Overall user experience
- Intuitive interface
- Performance and responsiveness
- Clarity of information displayed

**Steps**:
1. Use the application normally for several minutes
2. Try to find any usability issues or confusing elements
3. Note any suggestions for improvements
4. Test on different screen sizes and resolutions if possible

### Session 2: Edge Cases (30 minutes)
**Charter**: Explore potential edge cases and unusual usage patterns
**Areas to focus on**:
- Rapid clicking
- Window resizing while drawing cards
- Using the application for extended periods
- Multiple instances of the application running simultaneously

**Steps**:
1. Click the "Draw Card" button rapidly and repeatedly
2. Resize the window while actively using the application
3. Leave the application running for an extended period
4. Run multiple instances of the application (if possible)
5. Note any issues or unexpected behavior

### Session 3: Accessibility (30 minutes)
**Charter**: Explore the accessibility of the application
**Areas to focus on**:
- Text size and readability
- Color contrast in dark mode
- Keyboard navigation
- Screen reader compatibility (if applicable)

**Steps**:
1. Assess text size and readability
2. Check color contrast between text and backgrounds
3. Try navigating the application using only keyboard
4. Test with screen readers if available
5. Note any accessibility issues or barriers

## Test Results Reporting Template

For each manual or exploratory test session, please record:

- Test session date and time
- Tester name
- Environment details (OS, version, etc.)
- Summary of findings
- Detailed issues (with steps to reproduce)
- Screenshots of any issues
- Suggestions for improvements
