document.addEventListener("DOMContentLoaded", () => {
  // Hamburger Menu
  const HamburgerMenu = document.getElementById("hamburger-menu");
  HamburgerMenu.addEventListener("click", () => {});

  // Keuntungan Modal Effect On Click
  const KeuntunganModal = document.querySelectorAll("#keuntungan-modal");
  KeuntunganModal.forEach((modal) => {
    modal.addEventListener("mouseover", () => {
      modal.style.transform = "scale(1.1)";
    });
  });
});