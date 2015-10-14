/* global remark */

remark.highlighter.engine.registerLanguage("none", function() {	return {}});

remark.create({
	sourceUrl: "slideshow.md",
	highlightLines: true
});