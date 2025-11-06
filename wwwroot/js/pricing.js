
    document.addEventListener("DOMContentLoaded", function () {
    const accordion = document.getElementById("faqAccordion");

    accordion.addEventListener("shown.bs.collapse", function (event) {
        const collapseElement = event.target;

    // Auto close after 5 seconds (5000ms)
    setTimeout(function () {
            const bsCollapse = bootstrap.Collapse.getInstance(collapseElement);
    if (bsCollapse) bsCollapse.hide();
        }, 5000);
    });
});

