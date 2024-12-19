document.addEventListener("DOMContentLoaded", () => {
  // Hamburger Menu
  const HamburgerMenu = document.getElementById("hamburger-menu");
  const Sidebar = document.getElementById("sidebar");
  const Close = document.getElementById("close");

  HamburgerMenu.addEventListener("click", () => {
    Sidebar.classList.add("translate-x-0");
    document.body.style.overflow = "hidden";
  });

  Close.addEventListener("click", () => {
    Sidebar.classList.remove("translate-x-0");
    document.body.style.overflow = "auto";
  });

  // Keuntungan Modal Effect On Click
  const KeuntunganModal = document.querySelectorAll("#keuntungan-modal");

  KeuntunganModal.forEach((modal, index) => {
    modal.addEventListener("click", () => {
      let elements = [];
      index === 0 || index === 2 ? elements = [0, 2] : elements = [1, 3];

      elements.forEach((i) => {
        const targetModal = KeuntunganModal[i];
        targetModal.classList.contains("lg:-translate-y-6") ? targetModal.classList.remove("lg:-translate-y-6") : targetModal.classList.add("lg:-translate-y-6");
      });
    });
  });
});